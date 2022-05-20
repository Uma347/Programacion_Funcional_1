masos<-c("Espada","Corazon","Trebol","Rombo")
colores_m<-c("Negro","Rojo")
numeracion<-c("A",2:10,"J","Q","K")
Carta<-c(rep(numeracion,4))
Tipo<-c(rep(masos,rep(13,4)))
Color<-c(rep(colores_m,rep(13,2)))
baraja=data.frame(Carta,Tipo,Color)
baraja

