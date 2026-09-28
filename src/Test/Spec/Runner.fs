let exit (code: obj) = box (fun _ -> System.Console.Out.Flush(); System.Console.Error.Flush(); System.Environment.Exit(unbox<int> code); box null)
