using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Server
{
    public static class FileOperations
    {
        public const int KB = 1024;
        public const int MB = 1024 * KB;

        private const FileOptions NoBuffering = (FileOptions)0x20000000;

        [DllImport("Kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern SafeFileHandle CreateFile(string lpFileName, int dwDesiredAccess, FileShare dwShareMode, IntPtr securityAttrs, FileMode dwCreationDisposition, int dwFlagsAndAttributes, IntPtr hTemplateFile);

        public static int BufferSize { get; set; } = 1 * MB;
        public static int Concurrency { get; set; } = 1;
        public static bool Unbuffered { get; set; } = true;

        public static bool AreSynchronous => (Concurrency < 1);
        public static bool AreAsynchronous => (Concurrency > 0);

        public static FileStream OpenSequentialStream(string path, FileMode mode, FileAccess access, FileShare share)
        {
            FileOptions options = FileOptions.SequentialScan;

            if (Concurrency > 0)
            {
                options |= FileOptions.Asynchronous;
            }

            if (Unbuffered)
            {
                options |= NoBuffering;
            }
            else
            {
                return new FileStream(path, mode, access, share, BufferSize, options);
            }

            SafeFileHandle fileHandle = CreateFile(path, (int)access, share, IntPtr.Zero, mode, (int)options, IntPtr.Zero);

            if (fileHandle.IsInvalid)
            {
                throw new IOException();
            }

            return new UnbufferedFileStream(fileHandle, access, BufferSize, (Concurrency > 0));
        }

        private class UnbufferedFileStream : FileStream
        {
            private readonly SafeFileHandle fileHandle;

            public UnbufferedFileStream(SafeFileHandle _fileHandle, FileAccess access, int bufferSize, bool isAsync)
                : base(_fileHandle, access, bufferSize, isAsync)
            {
                fileHandle = _fileHandle;
            }

            public override void Write(byte[] array, int offset, int count)
            {
                base.Write(array, offset, BufferSize);
            }

            public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
            {
                return base.BeginWrite(array, offset, BufferSize, userCallback, stateObject);
            }

            protected override void Dispose(bool disposing)
            {
                if (!fileHandle.IsClosed)
                {
                    fileHandle.Close();
                }
                base.Dispose(disposing);
            }
        }
    }
}
