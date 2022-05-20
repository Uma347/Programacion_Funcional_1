from pyswip import Prolog

prolog = Prolog()
prolog.assertz("progenitor(juan,carla)")
prolog.assertz("progenitor(carla,pedro)")
prolog.assertz("progenitor(mario,pedro)")
prolog.assertz("progenitor(juan,luis)")
prolog.assertz("progenitor(luis,abigail)")
prolog.asserta("abuelo(X,Y):-progenitor(X,Z),progenitor(Z,Y)")
prolog.asserta("nieto(X,Y):-progenitor(Z,X),progenitor(Y,Z)")
prolog.asserta("hermano(X,Y):-progenitor(Z,X),progenitor(Z,Y),X\=Y")
prolog.asserta("primo(X,Y):-progenitor(Z,X),progenitor(W,Y),hermano(Z,W),X\=Y")


abuelos = list(prolog.query("abuelo(X,Y)"))

for abuelo in abuelos:
    print (abuelo["X"], " es abuel@ de ",abuelo["Y"] )
    
nietos= list(prolog.query("nieto(X,Y)"))

for nieto in nietos:
    print ( nieto["X"], " es niet@ de ",nieto["Y"] )
    
primos = list(prolog.query("primo(X,Y)"))

for primo in primos:
    print (primo["X"], " es prim@ de ",primo["Y"] )

prolog.retractall("progenitor(X,Y)")
prolog.retractall("abuelo(X,Y)")
prolog.retractall("nieto(X,Y)")
prolog.retractall("hermano(X,Y)")
prolog.retractall("primo(X,Y)")



        






