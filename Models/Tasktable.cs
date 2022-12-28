using System;
using System.Collections.Generic;

namespace todoAPIdotnet.Models;

public partial class Tasktable
{
    public int Tasknumber { get; set; }

    public string? Taskname { get; set; }

    public string? Taskstartdate { get; set; }

    public string? Taskenddate { get; set; }

    public string? Taskstatus { get; set; }
}
