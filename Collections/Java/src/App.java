import java.util.*;

public class App
{
    public static void main(String[] args) {
        listActions();
        dictionaryActions();
    }

    private static void listActions() {
        List<Employee> list = new ArrayList<>();

        list.add(new Employee("Mike", 25));
        list.add(new Employee("Sue", 45));

        for (Employee employee : list)
            System.out.println(employee.name + employee.age);

        for (int i=0; i<list.size(); i++)
            System.out.println(list.get(i).name + list.get(i).age);
    }

    private static void dictionaryActions() {
        Map<Integer, Employee> dict = new HashMap<>();
        //HashMap = random, LinkedHashMap = ordered, TreeMap = sorted

        dict.put(0, new Employee("Mike", 25));
        dict.put(1, new Employee("Sue", 45));
        dict.put(10, null); // compiles

        for (Map.Entry<Integer, Employee> pair : dict.entrySet())
            if (pair.getValue() != null)
                System.out.println(pair.getKey() + pair.getValue().name + pair.getValue().age);

        Set<Integer> keys = dict.keySet();
        Collection<Employee> employees = dict.values();

        dict.put(0, new Employee("Joe", 32));

        if (dict.containsKey(0)) {
            dict.get(0).name = "Mike";
            System.out.println(dict.get(0).name);
        }       
    }

    private static class Employee {
        public String name;
        public int age;

        public Employee(String name, int age) {
            this.name = name;
            this.age = age;
        }
    }
}