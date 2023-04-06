public class Student {
    private int id;
    private String name;
    private String standard;
    int totalMarks;

    Student(int totalMarks, String name, String standard, int id) {
        this.totalMarks = totalMarks;
        this.name = name;
        this.standard = standard;
        this.id = id;
    }

    Student()
    {
        //Default-Construktor
    }

    public void setName(String inputName){
        name = inputName;
    }
    public String getName(){
        return(name);
    }
    public void setStandard(String inputStandard){
        standard = inputStandard;
    }
    public String getStandard(){
        return(standard);
    }
    public void setId(int inputId){
        id = inputId;
    }
    public int getId(){
        return(id);
    }
    public void setTotalMarksId(int inputTotalMarks){
        totalMarks = inputTotalMarks;
    }
    public int getTotalMarks(){
        return(totalMarks);
    }


}