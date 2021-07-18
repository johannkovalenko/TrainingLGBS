import tkinter as tk
import myfunctionality as mf

class MyForm:   
    def __init__(self):
        self.__form = tk.Tk()
        self.__button = tk.Button(self.__form)

    def run(self):
        self.__form_settings()
        self.__button_settings()
        self.__event_handler()
        self.__form.mainloop()

    def __form_settings(self):
        self.__form.geometry('500x500')

    def __button_settings(self):
        self.__button.configure(    
            text = 'Click me', 
            bg = '#FCCC74', 
            fg = 'red',
            width = 9, # attention: these are text units and not pixels. 
            height = 1,
        )
        self.__button.pack()
        self.__button.place(x = 20, y = 20)

    def __event_handler(self):
        self.__button.bind('<Button>', self.__my_clicked)

    def __my_clicked(self, event):
        mf.MyFunctionality().run()