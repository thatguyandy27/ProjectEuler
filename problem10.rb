require 'prime'

#10 is 2 + 3 + 5 + 7 = 17.

limit = 2000000
puts Prime.each(limit).reduce(:+)