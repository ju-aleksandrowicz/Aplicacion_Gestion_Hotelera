# 🏨 Proyecto: Aplicación para Gestión Hotelera 🏨

[1. Participantes del proyecto](https://github.com/gutipy/CAI-TP_GRUPAL-Hotel#1-participantes-del-proyecto-)

[2. Contexto](https://github.com/gutipy/CAI-TP_GRUPAL-Hotel#2-contexto-)

[3. Situación ficticia](https://github.com/gutipy/CAI-TP_GRUPAL-Hotel#3-situación-ficticia-)

[4. Metodología y características técnicas del desarrollo](https://github.com/gutipy/CAI-TP_GRUPAL-Hotel#4-metodolog%C3%ADa-y-caracter%C3%ADsticas-técnicas-del-desarrollo-%EF%B8%8F)

## 1. Participantes del proyecto 👨🏻‍💻

### - Agustín Gutiérrez

![Foto de perfil de Agustín Gutiérrez](https://github.com/ju-aleksandrowicz/Aplicacion_Gestion_Hotelera/blob/main/Imagenes/perfil_agustin.jpg)

Nacido en Buenos Aires, Argentina. 26 años. Está cursando las últimas 5 materias de la carrera de Lic. en Sistemas.

Actualmente trabaja en Swiss Medical como analista de auditoría interna de Sistemas.

Tiene como objetivo profesional la búsqueda de aprendizaje de nuevos conocimientos en otras ramas de Sistemas tales como Desarrollo de software y Seguridad de la información.

### - Julian Aleksandrowicz

![Foto de perfil de Julián Aleksandrowicz](https://github.com/ju-aleksandrowicz/Aplicacion_Gestion_Hotelera/blob/main/Imagenes/perfil_julian.jpeg)

Nacido en Buenos Aires, Argentina. 28 años. Está cursando las últimas 4 materias de la carrera de Lic. en Sistemas.

Actualmente trabaja en la Empresa Argentina de Navegación Aérea como analista funcional y administrador de proyectos.

Dentro de su plan de desarrollo profesional se encuentra en búsqueda de una oportunidad para comenzar su camino como desarrollador de software en un equipo que le permita demostrar sus conocimientos aprendidos y adquirir nuevas habilidades.

### - Tomás Hardoy

![Foto de perfil de Tomás Hardoy](https://github.com/ju-aleksandrowicz/Aplicacion_Gestion_Hotelera/blob/main/Imagenes/tomas_hardoy1.png)

Nacido en Buenos Aires, Argentina. 24 años. Está cursando las últimas 4 materias de la carrera de Lic. en Sistemas.

Actualmente trabaja en Accenture como analista en el area de integracion de tecnologia y negocios.

Busca una carrera que le permita cubrir ese desentendimiento que suele haber entra las areas tecnologias y de negocios, siendo un nexo para entendimiento y colaboracion.

## 2. Contexto 📚

Este proyecto surge como **trabajo integrador** de la materia **"Construcción de Aplicaciones Informáticas"** dentro de la carrera de **Lic. en Sistemas de Información de las Organizaciones** de la Facultad de Ciencias Económicas (Universidad de Buenos Aires).

La materia se desarrolló utilizando el **lenguaje C#**. El enfoque permitió no solo aplicar fundamentos de diseño y programación, sino también **arquitectura en capas**, metodologías de desarrollo, tipos de pruebas, **programación orientada a objetos**; con foco en el correcto diseño de clases, herencia, polimorfismo, entre otros.

## 3. Situación ficticia 💰

El famoso Richard Texan ya no sabe en qué invertir su dinero. Su último capricho fue comprar una vieja y abandonada cadena de hoteles para refaccionar.


Al llegar el momento de poder brindar servicio nuevamente, contrató a los mejores candidatos para poner en las distintas gerencias, quedando él a cargo de las decisiones. Su equipo lo convenció de que, para no incurrir en pérdidas monetarias, debía invertir en un software con el cual gestionar todas las necesidades del hotel y sus huéspedes.


Lo que Texan consideraba crítico, y su equipo también, eran las reservas de las habitaciones en cada uno de los hoteles y, obviamente, poder obtener los reportes que sean necesarios para la gestión del hotel.

## 4. Metodología y características técnicas del desarrollo ⚙️

Explicamos como trabajamos y que usamos (visual, github, etc). problemas que surgieron y soluciones.

Para la metodologia de trabajo obviamente usamos Github como herramienta pero desde un principio optamos por dividirnos las capas armando una estructura inicial con las capas de Entidades, Negocio y Presentacion, lo cual nos permitio despreocuparnos por el manejo de las diferentes versiones y que nadie pisara el trabajo de otro.

Al comienzo surgieron problemas para entender como trabajar colaborativamente con Github ya que nunca lo habíamos hecho en equipo, pero lo que fuimos entendiendo es que siempre hay que "pullear" del repositorio compartido para tener los últimos cambios y una vez que terminamos de introducir los cambios realizamos un "push" para que se suban esos cambios a Github.

Adicionalmente, también hubo inconvenientes para entender el desarrollo de cada integrante de los equipos al momento de realizar controles en las capas de cada integrante, por lo cuál ahí la solución fue documentar el código mediante comentarios concisos e inteligentes, reuniones semanales de 30 minutos para poner en común con el equipo el significado del código y la utilización de convenciones estándar para que todos estemos en la misma sintonía.

Por último, al momento donde el programa ya compilaba, nos dedicamos a ver como se daba la conexión con el WebService y si los datos enviados/recibidos eran correctos. Ahí surgieron algunos problemas también donde los sorteamos a través de la utilización de mismos nombres para propiedades del programa y los atributos del JSON (dado que es Case Sensitive y por eso no nos devolvía algunos valores), validaciones adicionales para que el programa quede más sólido y pruebas en el WebService para considerar todas las alternativas posibles de ingreso de datos.
