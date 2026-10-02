# A converter for international currency exchange.
USD_to_GBP = 0.76 # Today's rate, US dollars to British Pounds
USD_to_EUR = 0.89 # Today's rate, US dollars to Euros (+ 0.03)
USD_to_JPY = 157.53 # Today's rate, US dollars to Japanese Yen (+ 43.45)
USD_to_INR = 63.64 # Today's rate, US dollars to Indian Rupees (+ 32.44)

GBP_sign = '\u00A3' # Unicode values for non-ASCII currency
EUR_sign = '\u20AC' # symbols.
JPY_sign = '\u00A5'
INR_sign = '\u20B9'

dollars = 1000 # The number of dollars to convert

pounds = dollars * USD_to_GBP # Conversion calculations
euros = dollars * USD_to_EUR
yen = dollars * USD_to_JPY
rupees = dollars * USD_to_INR

print('Today, $' + str(dollars)) # Printing the results
print('converts to ' + GBP_sign + str(pounds))
print('converts to ' + EUR_sign + str(euros))
print('converts to ' + JPY_sign + str(yen))
print('converts to ' + INR_sign + str(rupees))

# Today, $1000
# converts to £760.0
# converts to €890.0
# converts to ¥157530.0
# converts to ₹63640.0