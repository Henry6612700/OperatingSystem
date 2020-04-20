package sample;


public class Main {
    public static void main(String[] args) {
        Process[] processes = new Process[4];
        processes[0]=new Process(1,10,0);
        processes[1]=new Process(2,3,1);
        processes[2]=new Process(3,3,2);
        processes[3]=new Process(4,2,5);

        FCFS fcfs=new FCFS(processes);
        fcfs.printResult();

        SJF sjf=new SJF(processes);
        sjf.printResult();

        SJFPreemptive sjfp=new SJFPreemptive(processes);
        sjfp.printResult();

        RoundRobin roundRobin=new RoundRobin(processes,2);
        roundRobin.printResult();
    }
}
