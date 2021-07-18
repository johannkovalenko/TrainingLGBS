#include "header.h"

using namespace BirdChant;

int main() {
    IBird* myBird = factoryMethod(0);
    myBird->sing();

    IBird* birds[] = { new Sparrow(), new Mockingbird() };

    for (IBird* bird : birds)
        bird->sing();

    return 0;
}

IBird* factoryMethod(int number) {
    switch(number) {
        case 0:
            return new Sparrow();
        case 1:
            return new Mockingbird();
        default:
            return new Sparrow();
    }
}