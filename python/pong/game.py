""" PingPong

Doc:
    * window
    * 2 pedals interaction with keyboard (rect)
    * ball (circle)
    * scoreinformation (textlabel)

Class:
    - window
    - pedal
    - ball

Autor: HEISERH
Datum: 07.06.2022
Version: 1.0.0
Licence: free

"""

import turtle, random, time

class GameWindow:
    __win_width = 800
    __win_height = 600
    __background = "red"
    __title = "my awesome game"

    def __init__(self):
        self.window = turtle.Screen()
        self.window.title(self.__title)
        self.window.bgcolor(self.__background)
        self.window.setup(width=self.__win_width, height=self.__win_height)
        self.window.tracer(0)
        self.pen = turtle.Turtle()
        self.pen.speed(0)
        self.pen.color("white")
        self.pen.penup()
        self.pen.hideturtle()
        self.pen.goto(0, 260)

    def get_window_size(self):
        """get window size parameter

        Returns:
            tuple of window parameter: width x height
        """
        return self.__win_width, self.__win_height

    def show_point(self, a=0, b=0):
        """show points of all players

        Args:
            a (int, optional): point of player a. Defaults to 0.
            b (int, optional): points of player b. Defaults to 0.
        """
        self.pen.clear()
        self.pen.write(f"Player A: {a} Player B: {b}", align="center", font=("Courier", 24, "normal"))
        

class Paddle:
    __paddle_shape = "square"
    __paddle_color = "orange"
    __stretch_wid = 5
    __stretch_len = 1
    __player_points = 0

    def __init__(self, start_x):
        self.my_paddle = turtle.Turtle()
        self.my_paddle.speed(0)
        self.my_paddle.shape(self.__paddle_shape)
        self.my_paddle.color(self.__paddle_color)
        self.my_paddle.shapesize(stretch_wid=self.__stretch_wid, stretch_len=self.__stretch_len)
        self.my_paddle.penup()
        self.my_paddle.start_position = start_x
        self.my_paddle.goto(start_x, 0)
    
    def change_position(self, speed=20, direction=1):
        y = self.my_paddle.ycor()
        y += direction * speed
        self.my_paddle.sety(y)

    def get_points(self):
        return self.__player_points

    def set_points(self):
        self.__player_points +=1


class Ball:
    __start_position = (0,0)
    __ball_shape = "circle"
    __ball_color = "blue"
    __ball_speed = 3
    
    def __init__(self):
        self.ball = turtle.Turtle()
        self.ball.shape(self.__ball_shape)
        self.ball.color(self.__ball_color)
        self.ball.penup()
        self.ball.goto(self.__start_position)
        self.ball.__dx = self.ball.__dy = self.__ball_speed


    def __create_startposition(self):
        return (0, random.randint(-200, 200))


    def move_ball(self):
        self.ball.setx(self.ball.xcor() + self.ball.__dx)
        self.ball.sety(self.ball.ycor() + self.ball.__dy)

    def check_position(self, player_a, player_b, window):
        # hit top /bottom
        
        if self.ball.ycor() > window.get_window_size()[1]/2 - 10:
            self.ball.sety(window.get_window_size()[1]/2 - 10)
            self.ball.__dy *= -1
        elif self.ball.ycor() < -(window.get_window_size()[1]/2 -10):
            self.ball.sety(-(window.get_window_size()[1]/2 - 10))
            self.ball.__dy *= -1
        # hit out
        if self.ball.xcor() > window.get_window_size()[0]/2 - 10:
            self.ball.goto(self.__create_startposition())
            self.ball.__dx *= -1
            #TODO player point
            player_a.set_points()
        elif self.ball.xcor() < -(window.get_window_size()[0]/2 - 10):
            self.ball.goto(self.__create_startposition())
            self.ball.__dx *= -1
            #TODO: player point
            player_b.set_points()
        
        # hit player
        self.__check_collision([player_a, player_b])

    def __check_collision(self, playerlist):
        for player in playerlist:
            if player.my_paddle.start_position > 0:
                # right player
                if self.ball.xcor() + 10 > 340 and (self.ball.ycor() < player.my_paddle.ycor() + 50 and self.ball.ycor() > player.my_paddle.ycor() - 50):
                    self.ball.__dx *= -1
                
            else:
                # left player
                if self.ball.xcor() - 10 < -340 and (self.ball.ycor() < player.my_paddle.ycor() + 50 and self.ball.ycor() > player.my_paddle.ycor() - 50):
                    self.ball.__dx *= -1


def start_game():
    """gameController

    * initialize variables
    * initialize window
    * gameloop

    """

    #window init
    game_window = GameWindow()
    #variable init
    player_a = Paddle(-350) # left of window
    player_b = Paddle(350) # right of window

    ball = Ball()

    game_window.window.listen()
    game_window.window.onkeypress(lambda:player_a.change_position(), "w")
    game_window.window.onkeypress(lambda:player_a.change_position(direction=-1), "s")
    game_window.window.onkeypress(lambda:player_b.change_position(), "Up")
    game_window.window.onkeypress(lambda:player_b.change_position(direction=-1), "Down")

    #game loop
    print("DEBUG: start game")
    while True:
        time.sleep(1/1000)
        game_window.window.update()
        game_window.show_point(a=player_a.get_points(), b=player_b.get_points())
        ball.move_ball()
        ball.check_position(player_a=player_a, player_b=player_b, window=game_window)


if __name__ == "__main__":
    start_game()

    
