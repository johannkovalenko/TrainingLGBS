namespace BirdChant {
    class IBird {
        public:
            virtual void sing() = 0;
    };

    class Mockingbird : public IBird {
        public:
            void sing();
    };

    class Sparrow : public IBird {
        public:
            void sing();
    };
};

BirdChant::IBird* factoryMethod(int number);