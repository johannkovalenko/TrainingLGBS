import java.util.*;

public class App {
    public static void main(String[] args) {
        List<List<Point>> myList = new ArrayList<>();

        add(myList);
        loop(myList);
    }

    private static void add(List<List<Point>> myList) {
        for (int i=0; i<3; i++) {
            ArrayList<Point> tempList = new ArrayList<>();

            for (int j=0; j<3; j++) {
                Point point = new Point(i, j);
                tempList.add(point);

                tempList.add(new Point(i * 10, j * 10));           
            }
            myList.add(tempList);
        }
    }

    private static void loop(List<List<Point>> myList) {
        for (int i=0; i<myList.size(); i++)
            for (int j=0; j<myList.get(i).size(); j++) {
                System.out.print(myList.get(i).get(j).x + " ");
                System.out.println(myList.get(i).get(j).y);
            }
    }

    private static class Point {
        public int x;
        public int y;

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
}