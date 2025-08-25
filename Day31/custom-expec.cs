class AgeException: Exception {
    public AgeException(string msg): base(msg){}
}

int age = 15;
if(age<18) throw new AgeException("Age must be 18+");
