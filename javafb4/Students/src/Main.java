
public class Main {

    public static void main(String[] args) {
        int totalMarks = 0;
        int maxTotalMarks = 0;
        int indexStudent = 0;

        Student[] st = new Student[10];
        st[0] = new Student(100, "Hans", "9", 1);
        st[1] = new Student(132, "Felix", "9", 2);
        st[2] = new Student(115, "Mike", "10", 3);
        st[3] = new Student(130, "Joshua", "8", 4);
        st[4] = new Student(150, "Jens", "10", 5);
        st[5] = new Student(120, "Maurice", "7", 6);
        st[6] = new Student(110, "Luca", "9", 7);
        st[7] = new Student(111, "Fabian", "9", 8);
        st[8] = new Student(98, "Wayne", "10", 9);
        st[9] = new Student(95, "Max", "10", 10);
        //Testing if we can put data in a for loop, so we dont have to declarate each Student seperate


        /*
        Student[] st2 = new Student[3];
        for(int y = 0; y < st2.length; y++){
            st2[y] = new Student();
            st2[y].setId(y);
            st2[y].totalMarks = y;
            st2[y].setName("Holger");
            System.out.println("totalmarks: "+ st2[y].totalMarks + " ID: " + st2[y].getId() + " Name: " + st2[y].getName());
        }
        */


        //testing whos got the most totalMarks
        for (int i = 0; i < st.length; i++){
            System.out.println(st[i].totalMarks);
            totalMarks = st[i].totalMarks;

            if(st[i].totalMarks>maxTotalMarks){
                maxTotalMarks = totalMarks;
                indexStudent = i;
            }

        }
        System.out.println("The highest number of totalMarks is: " + maxTotalMarks);
        System.out.println("The student with the highest totalMarks is " + st[indexStudent].getName() + ", he is in "
        + st[indexStudent].getStandard() + " class and his id is " + st[indexStudent].getId() + ".");
    }
}