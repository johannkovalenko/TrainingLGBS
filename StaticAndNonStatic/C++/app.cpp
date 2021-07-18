#include<iostream>
#include<vector>
#include "header.h"

using namespace std;

int main() {

    vector<vector<Point*>*> myVector;

    add(myVector);
    loop(myVector);

    return 0;
}

void add(vector<vector<Point*>*> & myVector) {
    for (int i=0; i<3; i++) {
        vector<Point*> * tempVector = new vector<Point*>();

        for (int j=0; j<3; j++) {
            Point * point = new Point(i, j);
            tempVector->push_back(point);

            tempVector->push_back(new Point(i * 10, j * 10));           
        }
        myVector.push_back(tempVector);
    }
}

void loop(vector<vector<Point*>*> & myVector) {
    for (size_t i=0; i<myVector.size(); i++)
        for (size_t j=0; j<myVector[i]->size(); j++) {
            cout << myVector[i]->at(j)->x << " ";
            cout << myVector[i]->at(j)->y << "\r\n";
        }          
}