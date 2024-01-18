import random
from itertools import count
import pandas as pd
import matplotlib.pyplot as plt
from matplotlib.animation import FuncAnimation

x_vals = []
y_vals = []
index = count()

def animate(i):
    x_vals.append(next(index))
    y_vals.append(random.randint(0, 5))
    plt.cla()
    plt.plot(x_vals, y_vals)

ani = FuncAnimation(plt.gcf(), animate, interval=1000)

plt.style.use('fivethirtyeight')

# x_vals=[0, 1, 2, 3, 4, 5]
# y_vals=[0, 1, 3, 2, 3, 5]

# plt.plot(x_vals, y_vals)
plt.tight_layout()
# plt.savefig('plot.png')
plt.show()