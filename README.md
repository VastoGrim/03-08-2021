# 03/08/2021 - Jam
 Juego de dos clases

Equipo movimiento:                                  
A: 1 unidad hacia la izquierda               
W: 1 unidad hacia arriba                     
S: 1 unidad hacia abajo                      
D: 1 unidad hacia la derecha                 
Q:la forma rota hacia la izquierda           
E:la forma rota hacia  la derecha

Daniel Doroteo Batalla
Leonado Lorenzo Tinoco


clic derecho: disparo                        
                                             
una cara siempre verá al cursor              
                                             
cada cara tiene un disparo o función distinta


Equipo Armas:

habra 4 armas
solo estara activa el arma que apunte al cursor
cada arma tendra su propia bala
que asu vez, tendran diferentes atributos.
el arma se activara cuando se presione clic izquierdo

Cesar Gonzalo Tello Carrizales
Gustavo Andre Sanchez del Bosque
Pablo Rubio Torres

Procedimiento para armas:
equipo armas: Cesar Gonzalo Tello Carrizales
Gustavo Andre Sanchez del Bosque
Pablo Rubio Torres


Paso1: ubicar la cara "Principal del cubo"
paso2: hacer una caja invisible o hitbox y adjuntarle un script
paso3: crear "Keys" en cada cara, en total deberian ser 4, por ejemplo, key1,key2,key3,key4, y una vez esten estos hitboxes, deben darles un tag con dichos nombres distintivos
paso4: en el el script del hitbox principal se hara un codigo donde tendremos que hacer una condicional que este checando cada frame que llave con que tag, esta haciendo colicion y mandar a activar con trues y falses cada arma.

-----------------09/08/2021---------
Equipo Rotación
Leonardo
Danny

Se creo un child en Player que contiene como childs todos los cañones, la idea es que se rote el child con todos los cañones, asignando con un collider el cañon principal dandole su total funcionalidad. 
