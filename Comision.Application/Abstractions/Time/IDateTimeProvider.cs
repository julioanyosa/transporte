﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comision.Application.Abstractions.Time;
public interface IDateTimeProvider
{
    DateTime CurrentTime { get; }
}