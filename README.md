# Canicas

Se colocaron tres canicas sobre una plataforma, la última canica teniendo el triple de masa en comparación a las otras dos canicas. Después, se le dió un impulso (AddForce con ForceMode2D.Impulse) a la primera canica con una fuerza editable desde el inspector de Unity.

Se hicieron algunos lanzamientos cambiando diferentes variables como la fuerza de impulso y las masas de las canicas, las observaciones siguieron lo esperado, es decir: 

- Si la masa de la primera canica, a la cual se le otorga el impulso, es demasiado grande, se requiere que la fuerza de impulso también sea grande. De lo contrario, la fuerza de impulso no será suficiente para hacer que la primera canica se mueva. Por lo que: La velocidad con la cual la canica saldrá volando es proporcional a la fuerza de impulso, e inversamente proporcional a la masa de la canica.

- Lo previamente mencionado aplica con las demás canicas también, es decir, mientras más rápido golpee la primera canica a la segunda, mayor será la velocidad con la que la segunda canica sale disparada, y una mayor masa en la segunda canica representará una mayor dificultada para mover dicha canica.

- El impacto con la segunda canica disminuye la velocidad de la primera, por lo que para cuando la canica inicial impacte con la tercera, su velocidad será menor que la que tenía originalmente.

- Si se le da un valor de Linear Drag a las canicas, irán perdiendo velocidad a medida que avanzan, de lo contrario mantienen una velocidad fija hasta que impacten con otra canica.

- En la mayoría de las pruebas, el impulso dado a la primera canica fue suficiente para causar que las tres canicas cayeran. La primera golpeaba a la segunda, y la segunda a la tercera.
