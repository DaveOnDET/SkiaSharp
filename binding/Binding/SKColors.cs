﻿//
// Just contains various utility colors
//
// Author:
//   Miguel de Icaza
//
// Copyright 2015 Xamarin Inc
//
using System;

namespace SkiaSharp
{
	public struct SKColors
	{
		public static SKColor Empty => new SKColor (0x00000000);
		public static SKColor AliceBlue = new SKColor (0xFFF0F8FF);
		public static SKColor AntiqueWhite = new SKColor (0xFFFAEBD7);
		public static SKColor Aqua = new SKColor (0xFF00FFFF);
		public static SKColor Aquamarine = new SKColor (0xFF7FFFD4);
		public static SKColor Azure = new SKColor (0xFFF0FFFF);
		public static SKColor Beige = new SKColor (0xFFF5F5DC);
		public static SKColor Bisque = new SKColor (0xFFFFE4C4);
		public static SKColor Black = new SKColor (0xFF000000);
		public static SKColor BlanchedAlmond = new SKColor (0xFFFFEBCD);
		public static SKColor Blue = new SKColor (0xFF0000FF);
		public static SKColor BlueViolet = new SKColor (0xFF8A2BE2);
		public static SKColor Brown = new SKColor (0xFFA52A2A);
		public static SKColor BurlyWood = new SKColor (0xFFDEB887);
		public static SKColor CadetBlue = new SKColor (0xFF5F9EA0);
		public static SKColor Chartreuse = new SKColor (0xFF7FFF00);
		public static SKColor Chocolate = new SKColor (0xFFD2691E);
		public static SKColor Coral = new SKColor (0xFFFF7F50);
		public static SKColor CornflowerBlue = new SKColor (0xFF6495ED);
		public static SKColor Cornsilk = new SKColor (0xFFFFF8DC);
		public static SKColor Crimson = new SKColor (0xFFDC143C);
		public static SKColor Cyan = new SKColor (0xFF00FFFF);
		public static SKColor DarkBlue = new SKColor (0xFF00008B);
		public static SKColor DarkCyan = new SKColor (0xFF008B8B);
		public static SKColor DarkGoldenrod = new SKColor (0xFFB8860B);
		public static SKColor DarkGray = new SKColor (0xFFA9A9A9);
		public static SKColor DarkGreen = new SKColor (0xFF006400);
		public static SKColor DarkKhaki = new SKColor (0xFFBDB76B);
		public static SKColor DarkMagenta = new SKColor (0xFF8B008B);
		public static SKColor DarkOliveGreen = new SKColor (0xFF556B2F);
		public static SKColor DarkOrange = new SKColor (0xFFFF8C00);
		public static SKColor DarkOrchid = new SKColor (0xFF9932CC);
		public static SKColor DarkRed = new SKColor (0xFF8B0000);
		public static SKColor DarkSalmon = new SKColor (0xFFE9967A);
		public static SKColor DarkSeaGreen = new SKColor (0xFF8FBC8B);
		public static SKColor DarkSlateBlue = new SKColor (0xFF483D8B);
		public static SKColor DarkSlateGray = new SKColor (0xFF2F4F4F);
		public static SKColor DarkTurquoise = new SKColor (0xFF00CED1);
		public static SKColor DarkViolet = new SKColor (0xFF9400D3);
		public static SKColor DeepPink = new SKColor (0xFFFF1493);
		public static SKColor DeepSkyBlue = new SKColor (0xFF00BFFF);
		public static SKColor DimGray = new SKColor (0xFF696969);
		public static SKColor DodgerBlue = new SKColor (0xFF1E90FF);
		public static SKColor Firebrick = new SKColor (0xFFB22222);
		public static SKColor FloralWhite = new SKColor (0xFFFFFAF0);
		public static SKColor ForestGreen = new SKColor (0xFF228B22);
		public static SKColor Fuchsia = new SKColor (0xFFFF00FF);
		public static SKColor Gainsboro = new SKColor (0xFFDCDCDC);
		public static SKColor GhostWhite = new SKColor (0xFFF8F8FF);
		public static SKColor Gold = new SKColor (0xFFFFD700);
		public static SKColor Goldenrod = new SKColor (0xFFDAA520);
		public static SKColor Gray = new SKColor (0xFF808080);
		public static SKColor Green = new SKColor (0xFF008000);
		public static SKColor GreenYellow = new SKColor (0xFFADFF2F);
		public static SKColor Honeydew = new SKColor (0xFFF0FFF0);
		public static SKColor HotPink = new SKColor (0xFFFF69B4);
		public static SKColor IndianRed = new SKColor (0xFFCD5C5C);
		public static SKColor Indigo = new SKColor (0xFF4B0082);
		public static SKColor Ivory = new SKColor (0xFFFFFFF0);
		public static SKColor Khaki = new SKColor (0xFFF0E68C);
		public static SKColor Lavender = new SKColor (0xFFE6E6FA);
		public static SKColor LavenderBlush = new SKColor (0xFFFFF0F5);
		public static SKColor LawnGreen = new SKColor (0xFF7CFC00);
		public static SKColor LemonChiffon = new SKColor (0xFFFFFACD);
		public static SKColor LightBlue = new SKColor (0xFFADD8E6);
		public static SKColor LightCoral = new SKColor (0xFFF08080);
		public static SKColor LightCyan = new SKColor (0xFFE0FFFF);
		public static SKColor LightGoldenrodYellow = new SKColor (0xFFFAFAD2);
		public static SKColor LightGray = new SKColor (0xFFD3D3D3);
		public static SKColor LightGreen = new SKColor (0xFF90EE90);
		public static SKColor LightPink = new SKColor (0xFFFFB6C1);
		public static SKColor LightSalmon = new SKColor (0xFFFFA07A);
		public static SKColor LightSeaGreen = new SKColor (0xFF20B2AA);
		public static SKColor LightSkyBlue = new SKColor (0xFF87CEFA);
		public static SKColor LightSlateGray = new SKColor (0xFF778899);
		public static SKColor LightSteelBlue = new SKColor (0xFFB0C4DE);
		public static SKColor LightYellow = new SKColor (0xFFFFFFE0);
		public static SKColor Lime = new SKColor (0xFF00FF00);
		public static SKColor LimeGreen = new SKColor (0xFF32CD32);
		public static SKColor Linen = new SKColor (0xFFFAF0E6);
		public static SKColor Magenta = new SKColor (0xFFFF00FF);
		public static SKColor Maroon = new SKColor (0xFF800000);
		public static SKColor MediumAquamarine = new SKColor (0xFF66CDAA);
		public static SKColor MediumBlue = new SKColor (0xFF0000CD);
		public static SKColor MediumOrchid = new SKColor (0xFFBA55D3);
		public static SKColor MediumPurple = new SKColor (0xFF9370DB);
		public static SKColor MediumSeaGreen = new SKColor (0xFF3CB371);
		public static SKColor MediumSlateBlue = new SKColor (0xFF7B68EE);
		public static SKColor MediumSpringGreen = new SKColor (0xFF00FA9A);
		public static SKColor MediumTurquoise = new SKColor (0xFF48D1CC);
		public static SKColor MediumVioletRed = new SKColor (0xFFC71585);
		public static SKColor MidnightBlue = new SKColor (0xFF191970);
		public static SKColor MintCream = new SKColor (0xFFF5FFFA);
		public static SKColor MistyRose = new SKColor (0xFFFFE4E1);
		public static SKColor Moccasin = new SKColor (0xFFFFE4B5);
		public static SKColor NavajoWhite = new SKColor (0xFFFFDEAD);
		public static SKColor Navy = new SKColor (0xFF000080);
		public static SKColor OldLace = new SKColor (0xFFFDF5E6);
		public static SKColor Olive = new SKColor (0xFF808000);
		public static SKColor OliveDrab = new SKColor (0xFF6B8E23);
		public static SKColor Orange = new SKColor (0xFFFFA500);
		public static SKColor OrangeRed = new SKColor (0xFFFF4500);
		public static SKColor Orchid = new SKColor (0xFFDA70D6);
		public static SKColor PaleGoldenrod = new SKColor (0xFFEEE8AA);
		public static SKColor PaleGreen = new SKColor (0xFF98FB98);
		public static SKColor PaleTurquoise = new SKColor (0xFFAFEEEE);
		public static SKColor PaleVioletRed = new SKColor (0xFFDB7093);
		public static SKColor PapayaWhip = new SKColor (0xFFFFEFD5);
		public static SKColor PeachPuff = new SKColor (0xFFFFDAB9);
		public static SKColor Peru = new SKColor (0xFFCD853F);
		public static SKColor Pink = new SKColor (0xFFFFC0CB);
		public static SKColor Plum = new SKColor (0xFFDDA0DD);
		public static SKColor PowderBlue = new SKColor (0xFFB0E0E6);
		public static SKColor Purple = new SKColor (0xFF800080);
		public static SKColor Red = new SKColor (0xFFFF0000);
		public static SKColor RosyBrown = new SKColor (0xFFBC8F8F);
		public static SKColor RoyalBlue = new SKColor (0xFF4169E1);
		public static SKColor SaddleBrown = new SKColor (0xFF8B4513);
		public static SKColor Salmon = new SKColor (0xFFFA8072);
		public static SKColor SandyBrown = new SKColor (0xFFF4A460);
		public static SKColor SeaGreen = new SKColor (0xFF2E8B57);
		public static SKColor SeaShell = new SKColor (0xFFFFF5EE);
		public static SKColor Sienna = new SKColor (0xFFA0522D);
		public static SKColor Silver = new SKColor (0xFFC0C0C0);
		public static SKColor SkyBlue = new SKColor (0xFF87CEEB);
		public static SKColor SlateBlue = new SKColor (0xFF6A5ACD);
		public static SKColor SlateGray = new SKColor (0xFF708090);
		public static SKColor Snow = new SKColor (0xFFFFFAFA);
		public static SKColor SpringGreen = new SKColor (0xFF00FF7F);
		public static SKColor SteelBlue = new SKColor (0xFF4682B4);
		public static SKColor Tan = new SKColor (0xFFD2B48C);
		public static SKColor Teal = new SKColor (0xFF008080);
		public static SKColor Thistle = new SKColor (0xFFD8BFD8);
		public static SKColor Tomato = new SKColor (0xFFFF6347);
		public static SKColor Turquoise = new SKColor (0xFF40E0D0);
		public static SKColor Violet = new SKColor (0xFFEE82EE);
		public static SKColor Wheat = new SKColor (0xFFF5DEB3);
		public static SKColor White = new SKColor (0xFFFFFFFF);
		public static SKColor WhiteSmoke = new SKColor (0xFFF5F5F5);
		public static SKColor Yellow = new SKColor (0xFFFFFF00);
		public static SKColor YellowGreen = new SKColor (0xFF9ACD32);
		public static SKColor Transparent = new SKColor (0x00FFFFFF);
		
	}
}
