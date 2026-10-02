days_per_week = 7
weeks_per_year = 52
# So, there is one "semantic error" and one "logical error", the line below is a semantic error.
# I assume the authors meant to use the multiplication operator and not the exponent.
days_per_year = days_per_week ** weeks_per_year
# Error is below: PRINT() and print() are 2 different functions.
# print() exists by default but PRINT does not, so it's a NameError.
PRINT(days_per_year) 

# Traceback (most recent call last):
#   File "C:\Users\user\Development\OOPs-Engineers\src\png-cos\107.61-error\error.py", line 6, in <module>
#     PRINT(days_per_year)
#     ^^^^^
# NameError: name 'PRINT' is not defined