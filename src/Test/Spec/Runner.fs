let exit (code: obj) = box (fun _ -> System.Environment.Exit(unbox<int> code); box null)
