import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.Color;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class MyFrame implements Runnable {
    JFrame frame    = new JFrame();
    JButton button  = new JButton();

    public void run() {
        frameSettings();
        buttonSettings();
        eventHandler();

        frame.add(button);
    }

    private void frameSettings() {
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.pack();
        frame.setSize(500, 500);
        frame.setVisible(true);
    }

    private void buttonSettings() {
        button.setText("Click me");
        button.setBackground(new Color(252, 204, 116));
        button.setForeground(Color.RED);
        frame.setLayout(null); // activate absolute positioning
        button.setBounds(20, 20, 150, 50); //Location, Size
    }

    private void eventHandler() {
        ActionListener actionListener = new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                new MyFunctionality().run();
            }
        };

        button.addActionListener(actionListener);
    }
}
