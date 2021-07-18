fun main() {
    listActions()
    dictionaryActions()
}

fun listActions() {
    val list = mutableListOf<Employee>()

    list.add(Employee("Mike", 25))
    list.add(Employee("Sue", 45))

    for (employee : Employee in list)
        println(employee.name + employee.age)

    for (i : Int in list.indices)
        println(list[i].name + list[i].age)
}

fun dictionaryActions() {
    val dict = mutableMapOf<Int, Employee>()
    // mutableMapOf/mapOf = ordered, hashMapOf = random 

    dict.put(0, Employee("Mike", 25))
    dict.put(1, Employee("Sue", 45))
    //dict.put(10, null); // does not compile

    for ((key, value) in dict)
        println("${key} ${value.name} ${value.age}")

    var keys : Set<Int> = dict.keys
    var values : Collection<Employee> = dict.values

    dict.put(0, Employee("Joe", 32))

    dict[0]?.name = "Mike"
    println(dict[0]?.name)
}

data class Employee (var name : String, var age : Int)