package sample;

import java.util.ArrayList;
import java.util.Arrays;

public class SJFPreemptive extends SJF{
    public SJFPreemptive(Process[] processes) {
        super(processes);
    }

    @Override
    protected void apply() {
        ArrayList<Process> list=new ArrayList<>(Arrays.asList(processes));
        GrantChart grantChart=new GrantChart();
        time=0;
        total_waiting_time=0;
        average_waiting_time=0;
        Process process=null;

        while(list.size()>0){
            process=nextProcess(list,time);
            grantChart.schedule(process);
            process.remaining_burst_time--;
            if(process.remaining_burst_time==0) {
                list.remove(process);
            }
            time++;
        }
        grantChart.calculateWaitingTime();
        grantChart.print();
        average_waiting_time=grantChart.getTotal_waiting_time()/processes.length;
    }

    @Override
    public String getName() {
        return "SJF Preemptive";
    }
    protected Process nextProcess(ArrayList<Process> list, int time) {
        Process process=list.get(0);
        for(int i = 1;i<list.size();++i){
            if((list.get(i).getArrivingTime()<=time && list.get(i).remaining_burst_time<process.remaining_burst_time) || (
                    list.get(i).getArrivingTime()<=time && process.getArrivingTime()>time
            )){
                process=list.get(i);
            }
        }
        return process;
    }

    @Override
    public void printResult() {
        if(time==0){
            apply();
        }

        System.out.println();
        System.out.println(Process.getHeader());

        for(Process process : processes){
            System.out.println(process);
        }
        System.out.printf("%s Average waiting time %.2f\n",getName(),average_waiting_time);
    }
}
