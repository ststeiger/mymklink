using System;
using System.Collections.Generic;
using System.Text;

namespace mymklink
{

    // http://www.codeproject.com/Articles/15633/Manipulating-NTFS-Junction-Points-in-NET
    internal class mklink
    {

        internal enum SYMBOLIC_LINK_FLAG : uint
        {
            File = 0, // The link target is a file.
            Directory = 1 // The link target is a directory.
        }


        // http://msdn.microsoft.com/en-us/library/windows/desktop/aa363866(v=vs.85).aspx

        //BOOLEAN WINAPI CreateSymbolicLink(
        //  _In_  LPTSTR lpSymlinkFileName,
        //  _In_  LPTSTR lpTargetFileName,
        //  _In_  DWORD dwFlags
        //);

        // If the function succeeds, the return value is nonzero.
        // If the function fails, the return value is zero. To get extended error information, call GetLastError.


        // http://msdn.microsoft.com/en-us/library/cc230318.aspx
        // A DWORD or in .NET a UInt32.

        // lpSymlinkFileName [in]
        // The symbolic link to be created.

        // lpTargetFileName [in]
        //The name of the target for the symbolic link to be created.
        //If lpTargetFileName has a device name associated with it, the link is treated as an absolute link; otherwise, the link is treated as a relative link.

        //dwFlags [in]
        //Indicates whether the link target, lpTargetFileName, is a directory or a file.


        // http://www.pinvoke.net/default.aspx/kernel32.createsymboliclink

        // http://www.codeproject.com/Articles/11082/C-and-XML-Source-Code-Documentation

        /// <summary>
        /// Creates a symbolic link.
        /// To perform this operation as a transacted operation, use the CreateSymbolicLinkTransacted function.
        /// </summary>
        /// <param name="lpSymlinkFileName">The symbolic link to be created.</param>
        /// <param name="lpTargetFileName">The name of the target for the symbolic link to be created.</param>
        /// <param name="dwFlags">Indicates whether the link target, lpTargetFileName, is a directory or a file</param>
        /// <returns>If the function fails, the return value is zero. To get extended error information, call GetLastError</returns>
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
        internal static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SYMBOLIC_LINK_FLAG dwFlags);

    }


}
