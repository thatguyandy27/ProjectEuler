
def find_repeating_count(numerator, denominator)
  table = {}

  count = 0 
  begin 

    result = numerator/denominator

    remainder = numerator - (denominator * result)
    
    numerator = remainder * 10

    if table.include? (numerator)
      return count - table[numerator] 
    end
    #puts "#{result}"
    table[numerator] = count
    count += 1
    
  end while remainder != 0 
  
  return 0
end

def find_max(max)
  max_value = 0
  max_count = 0 
  
  max.downto(3) do |n|
    count = find_repeating_count(1, n)
    if count > max_count
      max_value = n
      max_count = count
    end
    
    if max_count > n
      return max_value
    end
  end

  return max_value
end

max_value = find_max(1000)
puts max_value