# firt time using elixir

:atom # defined by the `:` prefix, its value is itself

f = fn
    x, y -> IO.puts(x <> y) # <> concatenates binaries
end

IO.puts("Hello world from Elixir")
f.("This is an atom: ", :atom)
