package lista6zad1;
import java.io.*;

public class Main 
{
	public static void main(String[] args) throws IOException, ClassNotFoundException
	{
		List<Integer> List = new List<Integer> ();

		for (int i = 0; i < 10; i ++)
			List.pushBack(i);
		for (int i = 30; i < 40; i ++)
			List.pushFront(i);
		List.popBack();
		List.popFront();
		
		
		ObjectOutputStream out = new ObjectOutputStream(new FileOutputStream(new File("test.txt")));
		out.writeObject(List);
		out.close();
		List<Integer> read = null;
		ObjectInputStream in = new ObjectInputStream(new FileInputStream("test.txt"));
		read = (List) in.readObject();
		in.close();
		read.print();
		
		
		//List.print();
		/*
		try
        {
            FileOutputStream file = new FileOutputStream("test.txt");
            ObjectOutputStream strOut = new ObjectOutputStream(file);
            strOut.writeObject(List);
            strOut.close();
            file.close();
        }
		catch(IOException e)
        {
            e.printStackTrace();
        }
				
		List<Integer> read = null;
        try
        {
            FileInputStream file = new FileInputStream("test.txt");
            ObjectInputStream strIn = new ObjectInputStream(file);
            read = (List) strIn.readObject();
            strIn.close();
            file.close();
        }
        
        catch(IOException e)
        {
            e.printStackTrace();
            return;
        }
        catch(ClassNotFoundException e)
        {
            e.printStackTrace();
            return;
        }
        
        read.print();
        */
	} 			
}
