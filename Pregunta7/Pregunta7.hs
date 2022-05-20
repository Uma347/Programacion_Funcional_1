import System.Info

main = do
  print "Introduzca el 1er numero"
  n1 <- getLine
  print "Introduzca el 2do numero"
  n2 <- getLine
  let x = read n1 :: Double
  let y = read n2 :: Double
  
  
  let suma :: Double -> Double -> Double; suma a b = (a+b)
  let resta :: Double -> Double -> Double; resta a b = (a-b)
  let multiplicacion :: Double -> Double -> Double; multiplicacion a b = (a*b)
  let division :: Double -> Double -> Double; division a b = (a/b)
  print "Resultado de las operaciones"
  putStrLn $ "Suma           :" ++ show(suma x y)
  putStrLn $ "Resta          :" ++ show(resta x y)
  putStrLn $ "Meltiplicacion :" ++ show(multiplicacion x y)
  putStrLn $ "Division       :" ++ show(division x y)
  
  
  