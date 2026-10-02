days_per_week = 7
weeks_per_year = 52
# So, there is one "semantic error" and one "logical error", the line below is a semantic error.
# I assume the authors meant to use the multiplication operator and not the exponent.
# 
# The solution is to use the multiplication operator
days_per_year = days_per_week * weeks_per_year
# Error is below: PRINT() and print() are 2 different functions.
# print() exists by default but PRINT does not, so it's a NameError.
# 
# The solution is to just rename PRINT into print, so that the code works!
print(days_per_year) 
