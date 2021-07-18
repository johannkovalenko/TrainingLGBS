using namespace std;

struct Employee {
    string name;
    int age;

    public: Employee(string name, int age) {
        this->name = name;
        this->age = age;
    }
};

void listActions();
void dictionaryActions();