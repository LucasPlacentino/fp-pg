-- first time using haskell
main = do
  putStrLn "Hello world!"
  putStrLn ("Please look at my favorite odd numbers: " ++ show (filter even [10..20]))
