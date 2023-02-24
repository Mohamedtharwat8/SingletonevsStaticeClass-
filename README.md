### Singletone vs statice class :

## Similarties => 
can have only one instance of a copy
used for holding globale state of app
can be implemented as thread safe

## Differences => 
cannot create instance of Statice class but singletone can
compiler compiles static class internally => treates static class as an abstrace and sealed class
singletone class constructore as private , cannot create an instance from outside singletone class => public static propert or public static method  to create instance only once and return singletone instance  everytime
singletone class can be used as eager / lazy loading 
static class connot pass as a method parameter  
static class connot inherit 
singleton class object can be dispose
static class connot used dependency injection

