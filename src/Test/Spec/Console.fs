let write (s: obj) = box (fun _ -> System.Console.Out.Write(unbox<string> s); box null)
