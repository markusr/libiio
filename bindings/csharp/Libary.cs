/*
 * libiio - Library for interfacing industrial I/O (IIO) devices
 *
 * Copyright (C) 2015 Analog Devices, Inc.
 * Author: Paul Cercueil <paul.cercueil@analog.com>
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * */

namespace iio
{
    public class NativeLibrary
    {
        /// <summary>The name of the share library. Useful to compile for dotnet core.
        /// There is no easy way to solve the problem for various names in dotnet core.
        /// https://github.com/dotnet/coreclr/issues/930 </summary>
        public const string Name = "libiio.dll";
    }
}