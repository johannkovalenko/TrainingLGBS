import javax.swing.JFrame
import javax.swing.JButton
import java.awt.Color

class MyFrame {
    private val frame   = JFrame()
    private val button  = JButton()

    public fun run() {
        frameSettings()
        buttonSettings()
        eventHandler()

        frame.add(button);
    }

    private fun frameSettings() {
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE)
        frame.pack()
        frame.setSize(500, 500)
        frame.setVisible(true)
    }

    private fun buttonSettings() {
        button.setText("Click me")
        button.setBackground(Color(252, 204, 116))
        button.setForeground(Color.RED)
        frame.setLayout(null) // activate absolute positioning
        button.setBounds(20, 20, 150, 50) //Location, Size
    }

    private fun eventHandler() {
        button.addActionListener { MyFunctionality().run() }
    }
}
