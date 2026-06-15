using CCSharp.Attributes;

namespace CCSharp.ComputerCraft;

/// <summary>
/// Interact with a computer's terminal or monitors, writing text and drawing ASCII graphics.
/// </summary>
public static class Term {
    /// <summary>
    /// Get the default palette value for a colour.
    /// </summary>
    /// <param name="colour">The colour whose palette should be fetched.</param>
    /// <returns>number The red channel, will be between 0 and 1.</returns>
    /// <returns>number The green channel, will be between 0 and 1.</returns>
    /// <returns>number The blue channel, will be between 0 and 1.</returns>
    [LuaMethod("term.nativePaletteColour")]
    public static (double R, double G, double B) NativePaletteColour(int colour) => default;

    /// <summary>
    /// Get the default palette value for a colour.
    /// </summary>
    /// <param name="colour">The colour whose palette should be fetched.</param>
    /// <returns>number The red channel, will be between 0 and 1.</returns>
    /// <returns>number The green channel, will be between 0 and 1.</returns>
    /// <returns>number The blue channel, will be between 0 and 1.</returns>
    [LuaMethod("term.nativePaletteColor")]
    public static (double R, double G, double B) NativePaletteColor(int colour) => default;

    /// <summary>
    /// Write <paramref name="text"/> at the current cursor position, moving the cursor to the end of the text.
    /// Unlike functions like <c>write</c> and <c>print</c>, this does not wrap the text - it simply copies the text to the current terminal line.
    /// </summary>
    /// <param name="text">The text to write.</param>
    [LuaMethod("term.write")]
    public static void Write(string text) { }

    /// <summary>
    /// Move all positions up (or down) by <paramref name="y"/> pixels.
    /// Every pixel in the terminal will be replaced by the line <paramref name="y"/> pixels below it. If <paramref name="y"/> is negative, it will copy pixels from above instead.
    /// </summary>
    /// <param name="y">The number of lines to move up by. This may be a negative number.</param>
    [LuaMethod("term.scroll")]
    public static void Scroll(int y) { }

    /// <summary>
    /// Get the position of the cursor.
    /// </summary>
    /// <returns>number The x position of the cursor.</returns>
    /// <returns>number The y position of the cursor.</returns>
    [LuaMethod("term.getCursorPos")]
    public static (int X, int Y) GetCursorPos() => default;

    /// <summary>
    /// Set the position of the cursor. Terminal writes will begin from this position.
    /// </summary>
    /// <param name="x">The new x position of the cursor.</param>
    /// <param name="y">The new y position of the cursor.</param>
    [LuaMethod("term.setCursorPos")]
    public static void SetCursorPos(int x, int y) { }

    /// <summary>
    /// Checks if the cursor is currently blinking.
    /// </summary>
    /// <returns>boolean If the cursor is blinking.</returns>
    [LuaMethod("term.getCursorBlink")]
    public static bool GetCursorBlink() => default;

    /// <summary>
    /// Sets whether the cursor should be visible (and blinking) at the current cursor position.
    /// </summary>
    /// <param name="blink">Whether the cursor should blink.</param>
    [LuaMethod("term.setCursorBlink")]
    public static void SetCursorBlink(bool blink) { }

    /// <summary>
    /// Get the size of the terminal.
    /// </summary>
    /// <returns>number The terminal's width.</returns>
    /// <returns>number The terminal's height.</returns>
    [LuaMethod("term.getSize")]
    public static (int Width, int Height) GetSize() => default;

    /// <summary>
    /// Clears the terminal, filling it with the current background colour.
    /// </summary>
    [LuaMethod("term.clear")]
    public static void Clear() { }

    /// <summary>
    /// Clears the line the cursor is currently on, filling it with the current background colour.
    /// </summary>
    [LuaMethod("term.clearLine")]
    public static void ClearLine() { }

    /// <summary>
    /// Return the colour that new text will be written as.
    /// </summary>
    /// <returns>number The current text colour.</returns>
    [LuaMethod("term.getTextColour")]
    public static int GetTextColour() => default;

    /// <summary>
    /// Return the colour that new text will be written as.
    /// </summary>
    /// <returns>number The current text colour.</returns>
    [LuaMethod("term.getTextColor")]
    public static int GetTextColor() => default;

    /// <summary>
    /// Set the colour that new text will be written as.
    /// </summary>
    /// <param name="colour">The new text colour.</param>
    [LuaMethod("term.setTextColour")]
    public static void SetTextColour(int colour) { }

    /// <summary>
    /// Set the colour that new text will be written as.
    /// </summary>
    /// <param name="colour">The new text colour.</param>
    [LuaMethod("term.setTextColor")]
    public static void SetTextColor(int colour) { }

    /// <summary>
    /// Return the current background colour. This is used when writing text and clearing the terminal.
    /// </summary>
    /// <returns>number The current background colour.</returns>
    [LuaMethod("term.getBackgroundColour")]
    public static int GetBackgroundColour() => default;

    /// <summary>
    /// Return the current background colour. This is used when writing text and clearing the terminal.
    /// </summary>
    /// <returns>number The current background colour.</returns>
    [LuaMethod("term.getBackgroundColor")]
    public static int GetBackgroundColor() => default;

    /// <summary>
    /// Set the current background colour. This is used when writing text and clearing the terminal.
    /// </summary>
    /// <param name="colour">The new background colour.</param>
    [LuaMethod("term.setBackgroundColour")]
    public static void SetBackgroundColour(int colour) { }

    /// <summary>
    /// Set the current background colour. This is used when writing text and clearing the terminal.
    /// </summary>
    /// <param name="colour">The new background colour.</param>
    [LuaMethod("term.setBackgroundColor")]
    public static void SetBackgroundColor(int colour) { }

    /// <summary>
    /// Determine if this terminal supports colour.
    /// Terminals which do not support colour will still allow writing coloured text/backgrounds, but it will be displayed in greyscale.
    /// </summary>
    /// <returns>boolean Whether this terminal supports colour.</returns>
    [LuaMethod("term.isColour")]
    public static bool IsColour() => default;

    /// <summary>
    /// Determine if this terminal supports colour.
    /// Terminals which do not support colour will still allow writing coloured text/backgrounds, but it will be displayed in greyscale.
    /// </summary>
    /// <returns>boolean Whether this terminal supports colour.</returns>
    [LuaMethod("term.isColor")]
    public static bool IsColor() => default;

    /// <summary>
    /// Writes <paramref name="text"/> to the terminal with the specific foreground and background colours.
    /// As with <see cref="Write"/>, the text will be written at the current cursor location, with the cursor moving to the end of the text.
    /// <paramref name="textColour"/> and <paramref name="backgroundColour"/> must both be strings the same length as <paramref name="text"/>.
    /// </summary>
    /// <param name="text">The text to write.</param>
    /// <param name="textColour">The corresponding text colours.</param>
    /// <param name="backgroundColour">The corresponding background colours.</param>
    [LuaMethod("term.blit")]
    public static void Blit(string text, string textColour, string backgroundColour) { }

    /// <summary>
    /// Set the palette for a specific colour using a 24-bit RGB value.
    /// ComputerCraft's palette system allows you to change how a specific colour should be displayed.
    /// </summary>
    /// <param name="index">The colour whose palette should be changed.</param>
    /// <param name="colour">A 24-bit integer representing the RGB value of the colour. For instance the integer <c>0xFF0000</c> corresponds to the colour #FF0000.</param>
    [LuaMethod("term.setPaletteColour")]
    public static void SetPaletteColour(int index, int colour) { }

    /// <summary>
    /// Set the palette for a specific colour by specifying each colour channel separately.
    /// </summary>
    /// <param name="index">The colour whose palette should be changed.</param>
    /// <param name="r">The intensity of the red channel, between 0 and 1.</param>
    /// <param name="g">The intensity of the green channel, between 0 and 1.</param>
    /// <param name="b">The intensity of the blue channel, between 0 and 1.</param>
    [LuaMethod("term.setPaletteColour")]
    public static void SetPaletteColour(int index, double r, double g, double b) { }

    /// <summary>
    /// Set the palette for a specific colour using a 24-bit RGB value.
    /// </summary>
    /// <param name="index">The colour whose palette should be changed.</param>
    /// <param name="colour">A 24-bit integer representing the RGB value of the colour.</param>
    [LuaMethod("term.setPaletteColor")]
    public static void SetPaletteColor(int index, int colour) { }

    /// <summary>
    /// Set the palette for a specific colour by specifying each colour channel separately.
    /// </summary>
    /// <param name="index">The colour whose palette should be changed.</param>
    /// <param name="r">The intensity of the red channel, between 0 and 1.</param>
    /// <param name="g">The intensity of the green channel, between 0 and 1.</param>
    /// <param name="b">The intensity of the blue channel, between 0 and 1.</param>
    [LuaMethod("term.setPaletteColor")]
    public static void SetPaletteColor(int index, double r, double g, double b) { }

    /// <summary>
    /// Get the current palette for a specific colour.
    /// </summary>
    /// <param name="colour">The colour whose palette should be fetched.</param>
    /// <returns>number The red channel, will be between 0 and 1.</returns>
    /// <returns>number The green channel, will be between 0 and 1.</returns>
    /// <returns>number The blue channel, will be between 0 and 1.</returns>
    [LuaMethod("term.getPaletteColour")]
    public static (double R, double G, double B) GetPaletteColour(int colour) => default;

    /// <summary>
    /// Get the current palette for a specific colour.
    /// </summary>
    /// <param name="colour">The colour whose palette should be fetched.</param>
    /// <returns>number The red channel, will be between 0 and 1.</returns>
    /// <returns>number The green channel, will be between 0 and 1.</returns>
    /// <returns>number The blue channel, will be between 0 and 1.</returns>
    [LuaMethod("term.getPaletteColor")]
    public static (double R, double G, double B) GetPaletteColor(int colour) => default;

    /// <summary>
    /// Redirects terminal output to a monitor, a window, or any other custom terminal object.
    /// The redirect can be undone by pointing back to the previous terminal object returned by this function.
    /// </summary>
    /// <param name="target">The terminal redirect the term API will draw to.</param>
    /// <returns>The previous redirect object, as returned by <see cref="Current"/>.</returns>
    [LuaMethod("term.redirect")]
    public static TermRedirect Redirect(TermRedirect target) => default;

    /// <summary>
    /// Returns the current terminal object of the computer.
    /// </summary>
    /// <returns>The current terminal redirect.</returns>
    [LuaMethod("term.current")]
    public static TermRedirect Current() => default;

    /// <summary>
    /// Get the native terminal object of the current computer.
    /// It is recommended you do not use this function unless you absolutely have to.
    /// </summary>
    /// <returns>The native terminal redirect.</returns>
    [LuaMethod("term.native")]
    public static TermRedirect Native() => default;
}
