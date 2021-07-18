fun main() {
    val myList = mutableListOf<MutableList<Point>>()

    add(myList)
    loop(myList)
}

private fun add(myList : MutableList<MutableList<Point>>) {
    for (i : Int in 0..2) {
        val tempList = mutableListOf<Point>()

        for (j : Int in 0..2) {
            val point = Point(i, j)
            tempList.add(point)

            tempList.add(Point(i * 10, j * 10))           
        }
        myList.add(tempList)
    }
}

private fun loop(myList : MutableList<MutableList<Point>>) {
    for (i : Int in myList.indices)
        for (j : Int in myList[i].indices) {
            print("${myList[i][j].x} ")
            println("${myList[i][j].y}")
        }
}

class Point (val x : Int, val y : Int)