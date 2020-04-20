package sample;

import java.util.ArrayList;
import java.util.SortedSet;
import java.util.TreeSet;

public class GrantChart {
    private ArrayList<Part> parts;
    private SortedSet<Process> processes;
    private int time;
    private int total_waiting_time;

    public GrantChart() {
        parts = new ArrayList<>();
        processes=new TreeSet<>(new IdComparator());
        time = 0;
    }

    public void schedule(Process process) {
        int last = parts.size()-1;
        if (last >= 0 && parts.get(last).getProcess() != process) {
            parts.get(last).complete(time);
        }
        if (last == -1 || parts.get(last).getProcess() != process) {
            parts.add(new Part(process, time));
        } else {
            parts.get(last).complete(time+1);
        }
        time++;
    }

    public void passTime(int length){
        time+=length-1;
        parts.get(parts.size()-1).complete(time);
    }

    public boolean isProcessStarted(Process process) {
        for (Part part : parts) {
            if (part.getProcess() == process) {
                return true;
            }
        }
        return false;
    }

    public int getTime(){
        return time;
    }

    public double getTotal_waiting_time(){
        return total_waiting_time;
    }

    public void calculateWaitingTime(){
        total_waiting_time=0;
        for(Part part:parts){
            processes.add(part.getProcess());
        }
        for(Process process:processes){
            Part previous=null;
            int begin;
            int waiting_time=0;
            for(Part part:parts){
                if (part.getProcess()==process){
                    if(previous == null){
                        previous = part;
                        begin = part.getStart();
                        process.setStartingTime(begin);
                        waiting_time=process.getStartingTime()-process.getArrivingTime();
                    }else{
                        waiting_time+=part.getStart()-previous.getEnd();
                        previous=part;
                    }
                }
            }
            process.setWaitingTime(waiting_time);
            total_waiting_time +=waiting_time;
        }
    }

    public void print(){
        System.out.println("\nGrant Chart");
        System.out.println("-------------");
        for(Part part:parts){
            System.out.println(part.getProcess().getId());
        }
        System.out.println();
        int i=0;
        for(Part part:parts){
            System.out.println(part.getStart());
            if(i == parts.size()-1){
                System.out.println(part.getEnd());
            }
            i++;
        }
        System.out.println();
    }
}
