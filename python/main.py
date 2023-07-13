import statistics

admins = {'Python':'Pass123@', 'user2':'pass2!'}
students = {"Henrik":"TestPW123", "Maurice":"A§%(AS)@AF?!", "Alfred":12345}
studentDict = {'Henrik': [78,88,93], 'Maurice': [92,76,88], 'Alfred':[89,92,93]}

loop = True

def admin():
    print("""welcome to grade central
    [1] - enter grades
    [2] - remove student
    [3] - student average grades
    [4] - exit""")
    action = input('enter specific number: ')
    if action == '1':
        entergrades()
    elif action == '2':
        removestudent()
    elif action == '3':
        studentAvgGrades()
    elif action == '4':
        exit()
    else:
        print("I can't help you with that.")

def student():
    print("""welcome to grade central
    [1] - show grades
    [2] - exit""")
    action = input('enter specific number: ')
    if action == '1':
        print(studentDict[login])
    elif action == '2':
        exit()
    else:
        print("I can't help you with that.")

#enter grades function check before wether student exist or not
def entergrades():
    nametoenter = input('studentname: ')
    gradetoenter = input('grade:')
    if nametoenter in studentDict:
        print('adding grade...')
        studentDict[nametoenter].append(float(gradetoenter))
    else:
        print('student does not exist')
    print(studentDict)

#remove student from database function
def removestudent():
    nametoremove = input('Which student do you want to remove: ')
    if nametoremove in studentDict:
        print('removing ', nametoremove, 'from the database.')
        del studentDict[nametoremove]
        del students[nametoremove]
    else:
        print('Couldnt find that student')
    print(studentDict)

#calculate the avg grades from a student
def studentAvgGrades():
    nametocheck = input("Type in the name of the student you want to check the avg grades: ")
    if nametocheck in studentDict:
        gradelist = studentDict[nametocheck]
        avgGrade = statistics.mean(gradelist)
        print(avgGrade)
    else:
        print("Error. Couldnt find student.")

# program body before main function
login = input('Username: ')
passw = input('Password: ')
if login in admins:
    if admins[login] == passw:
        print('welcome,',login)
        while loop:
            input()
            admin()
    else:
        print('invalid password - system shutdown in 10 seconds')
elif login in students:
    if students[login] == passw:
        print('welcome', login)
        while loop:
            input()
            student()
    else:
        print('invalid password - system shutdown in 10 seconds')
else:
    print('invalid username, this incident will be reported - see logfile')




