from BirdChant.Sparrow import Sparrow
from BirdChant.Mockingbird import Mockingbird

def factory_method(number):
    if number == 0:
        return Sparrow()
    elif number == 1:
        return Mockingbird()
    else:
        return Sparrow()

myBird = factory_method(1) # Duck-Typing
myBird.sing()

birds = [ 
    Sparrow(),
    Mockingbird()
] # Duck-Typing

for bird in birds:
    bird.sing()




