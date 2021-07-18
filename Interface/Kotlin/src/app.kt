import birdchant.IBird
import birdchant.Sparrow
import birdchant.Mockingbird

fun main() {
    val myBird : IBird = factoryMethod(0)
    myBird.sing()

    val birds = arrayOf(Sparrow(), Mockingbird())

    for (bird : IBird in birds)
        bird.sing()
}

fun factoryMethod(number : Int) : IBird {
    when (number) {
        0 -> return Sparrow()
        1 -> return Mockingbird()
        else -> {
            return Sparrow()
        }
    }
}