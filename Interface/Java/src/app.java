import birdchant.IBird;
import birdchant.Sparrow;
import birdchant.Mockingbird;

class App {
    public static void main(String[] args) {
        IBird myBird = factoryMethod(0);
        myBird.sing();

        IBird[] birds = {new Sparrow(), new Mockingbird()};

        for (IBird bird : birds)
            bird.sing();
    }

    private static IBird factoryMethod(int number) {
        switch(number) {
            case 0:
                return new Sparrow();
            case 1:
                return new Mockingbird();
            default:
                return new Sparrow();
        }
    }
}