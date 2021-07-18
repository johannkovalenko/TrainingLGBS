#include<vector>

using namespace std;

struct Point {
    int x;
    int y;

    Point(int x, int y) {
        this->x = x;
        this->y = y;
    }
};

void add(vector<vector<Point*>*> & test);
void loop(vector<vector<Point*>*> & test);