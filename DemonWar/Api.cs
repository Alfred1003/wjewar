using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace WjeWar
{
    class Api
    {

        /// <summary>�õ�������
        /// 
        /// </summary>
        /// <param name="lpClassName"></param>
        /// <param name="lpWindowName"></param>
        /// <returns></returns>
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        /// <summary>�õ���괦���
        /// 
        /// </summary>
        /// <param name="Point"></param>
        /// <returns></returns>
        [DllImport("user32", EntryPoint = "WindowFromPoint")]
        public static extern IntPtr WindowFromPoint(System.Drawing.Point Point);
    }
}
