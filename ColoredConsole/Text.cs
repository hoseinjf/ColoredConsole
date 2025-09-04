

namespace ColoredConsole
{
    /// <summary>
    /// A static helper class for writing colored text to the console.
    /// This version supports generics, string formatting, and interpolated strings automatically.
    /// </summary>
    public static class Text
    {


        #region Private Core Methods

        /// <summary>
        /// The core private method that handles printing a single value.
        /// </summary>
        private static void Print<T>(T value, ConsoleColor color, bool writeLine)
        {
            Console.ForegroundColor = color;
            if (writeLine)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.Write(value);
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Overloaded core private method to handle formatted strings.
        /// </summary>
        private static void Print(string format, object[] args, ConsoleColor color, bool writeLine)
        {
            Console.ForegroundColor = color;
            if (writeLine)
            {
                Console.WriteLine(format, args);
            }
            else
            {
                Console.Write(format, args);
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Private helper to print a colored empty line.
        /// </summary>
        private static void PrintEmptyLine(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine();
            Console.ResetColor();
        }

        #endregion


        #region Color Methods

        // --- Red ---
        public static void Red<T>(T value) => Print(value, ConsoleColor.Red, false);
        public static void Red(string format, params object[] args) => Print(format, args, ConsoleColor.Red, false);
        public static void RedLine<T>(T value) => Print(value, ConsoleColor.Red, true);
        public static void RedLine(string format, params object[] args) => Print(format, args, ConsoleColor.Red, true);
        public static void RedLine() => PrintEmptyLine(ConsoleColor.Red);

        // --- Green ---
        public static void Green<T>(T value) => Print(value, ConsoleColor.Green, false);
        public static void Green(string format, params object[] args) => Print(format, args, ConsoleColor.Green, false);
        public static void GreenLine<T>(T value) => Print(value, ConsoleColor.Green, true);
        public static void GreenLine(string format, params object[] args) => Print(format, args, ConsoleColor.Green, true);
        public static void GreenLine() => PrintEmptyLine(ConsoleColor.Green);

        // --- Yellow ---
        public static void Yellow<T>(T value) => Print(value, ConsoleColor.Yellow, false);
        public static void Yellow(string format, params object[] args) => Print(format, args, ConsoleColor.Yellow, false);
        public static void YellowLine<T>(T value) => Print(value, ConsoleColor.Yellow, true);
        public static void YellowLine(string format, params object[] args) => Print(format, args, ConsoleColor.Yellow, true);
        public static void YellowLine() => PrintEmptyLine(ConsoleColor.Yellow);


        // --- Blue ---
        public static void Blue<T>(T value) => Print(value, ConsoleColor.Blue, false);
        public static void Blue(string format, params object[] args) => Print(format, args, ConsoleColor.Blue, false);
        public static void BlueLine<T>(T value) => Print(value, ConsoleColor.Blue, true);
        public static void BlueLine(string format, params object[] args) => Print(format, args, ConsoleColor.Blue, true);
        public static void BlueLine() => PrintEmptyLine(ConsoleColor.Blue);

        // --- Cyan ---
        public static void Cyan<T>(T value) => Print(value, ConsoleColor.Cyan, false);
        public static void Cyan(string format, params object[] args) => Print(format, args, ConsoleColor.Cyan, false);
        public static void CyanLine<T>(T value) => Print(value, ConsoleColor.Cyan, true);
        public static void CyanLine(string format, params object[] args) => Print(format, args, ConsoleColor.Cyan, true);
        public static void CyanLine() => PrintEmptyLine(ConsoleColor.Cyan);

        // --- White ---
        public static void White<T>(T value) => Print(value, ConsoleColor.White, false);
        public static void White(string format, params object[] args) => Print(format, args, ConsoleColor.White, false);
        public static void WhiteLine<T>(T value) => Print(value, ConsoleColor.White, true);
        public static void WhiteLine(string format, params object[] args) => Print(format, args, ConsoleColor.White, true);
        public static void WhiteLine() => PrintEmptyLine(ConsoleColor.White);

        // --- Black ---
        public static void Black<T>(T value) => Print(value, ConsoleColor.Black, false);
        public static void Black(string format, params object[] args) => Print(format, args, ConsoleColor.Black, false);
        public static void BlackLine<T>(T value) => Print(value, ConsoleColor.Black, true);
        public static void BlackLine(string format, params object[] args) => Print(format, args, ConsoleColor.Black, true);
        public static void BlackLine() => PrintEmptyLine(ConsoleColor.Black);


        // --- Gray ---
        public static void Gray<T>(T value) => Print(value, ConsoleColor.Gray, false);
        public static void Gray(string format, params object[] args) => Print(format, args, ConsoleColor.Gray, false);
        public static void GrayLine<T>(T value) => Print(value, ConsoleColor.Gray, true);
        public static void GrayLine(string format, params object[] args) => Print(format, args, ConsoleColor.Gray, true);
        public static void GrayLine() => PrintEmptyLine(ConsoleColor.Gray);


        // --- Magenta ---
        public static void Magenta<T>(T value) => Print(value, ConsoleColor.Magenta, false);
        public static void Magenta(string format, params object[] args) => Print(format, args, ConsoleColor.Magenta, false);
        public static void MagentaLine<T>(T value) => Print(value, ConsoleColor.Magenta, true);
        public static void MagentaLine(string format, params object[] args) => Print(format, args, ConsoleColor.Magenta, true);
        public static void MagentaLine() => PrintEmptyLine(ConsoleColor.Magenta);


        // --- DarkRed ---
        public static void DarkRed<T>(T value) => Print(value, ConsoleColor.DarkRed, false);
        public static void DarkRed(string format, params object[] args) => Print(format, args, ConsoleColor.DarkRed, false);
        public static void DarkRedLine<T>(T value) => Print(value, ConsoleColor.DarkRed, true);
        public static void DarkRedLine(string format, params object[] args) => Print(format, args, ConsoleColor.DarkRed, true);
        public static void DarkRedLine() => PrintEmptyLine(ConsoleColor.DarkRed);


        // --- DarkYellow ---
        public static void DarkYellow<T>(T value) => Print(value, ConsoleColor.DarkYellow, false);
        public static void DarkYellow(string format, params object[] args) => Print(format, args, ConsoleColor.DarkYellow, false);
        public static void DarkYellowLine<T>(T value) => Print(value, ConsoleColor.DarkYellow, true);
        public static void DarkYellowLine(string format, params object[] args) => Print(format, args, ConsoleColor.DarkYellow, true);
        public static void DarkYellowLine() => PrintEmptyLine(ConsoleColor.DarkYellow);


        // --- DarkBlue ---
        public static void DarkBlue<T>(T value) => Print(value, ConsoleColor.DarkBlue, false);
        public static void DarkBlue(string format, params object[] args) => Print(format, args, ConsoleColor.DarkBlue, false);
        public static void DarkBlueLine<T>(T value) => Print(value, ConsoleColor.DarkBlue, true);
        public static void DarkBlueLine(string format, params object[] args) => Print(format, args, ConsoleColor.DarkBlue, true);
        public static void DarkBlueLine() => PrintEmptyLine(ConsoleColor.DarkBlue);


        // --- DarkGray ---
        public static void DarkGray<T>(T value) => Print(value, ConsoleColor.DarkGray, false);
        public static void DarkGray(string format, params object[] args) => Print(format, args, ConsoleColor.DarkGray, false);
        public static void DarkGrayLine<T>(T value) => Print(value, ConsoleColor.DarkGray, true);
        public static void DarkGrayLine(string format, params object[] args) => Print(format, args, ConsoleColor.DarkGray, true);
        public static void DarkGrayLine() => PrintEmptyLine(ConsoleColor.DarkGray);


        // --- DarkGreen ---
        public static void DarkGreen<T>(T value) => Print(value, ConsoleColor.DarkGreen, false);
        public static void DarkGreen(string format, params object[] args) => Print(format, args, ConsoleColor.DarkGreen, false);
        public static void DarkGreenLine<T>(T value) => Print(value, ConsoleColor.DarkGreen, true);
        public static void DarkGreenLine(string format, params object[] args) => Print(format, args, ConsoleColor.DarkGreen, true);
        public static void DarkGreenLine() => PrintEmptyLine(ConsoleColor.DarkGreen);


        // --- DarkCyan ---
        public static void DarkCyan<T>(T value) => Print(value, ConsoleColor.DarkCyan, false);
        public static void DarkCyan(string format, params object[] args) => Print(format, args, ConsoleColor.DarkCyan, false);
        public static void DarkCyanLine<T>(T value) => Print(value, ConsoleColor.DarkCyan, true);
        public static void DarkCyanLine(string format, params object[] args) => Print(format, args, ConsoleColor.DarkCyan, true);
        public static void DarkCyanLine() => PrintEmptyLine(ConsoleColor.DarkCyan);


        // --- DarkMagenta ---
        public static void DarkMagenta<T>(T value) => Print(value, ConsoleColor.DarkMagenta, false);
        public static void DarkMagenta(string format, params object[] args) => Print(format, args, ConsoleColor.DarkMagenta, false);
        public static void DarkMagentaLine<T>(T value) => Print(value, ConsoleColor.DarkMagenta, true);
        public static void DarkMagentaLine(string format, params object[] args) => Print(format, args, ConsoleColor.DarkMagenta, true);
        public static void DarkMagentaLine() => PrintEmptyLine(ConsoleColor.DarkMagenta);


        #endregion


    }
}
