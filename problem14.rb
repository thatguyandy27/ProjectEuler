

def find_longest_chain(limit)
  chain_start = 0
  max_chain = 0
  
  (limit -1 ).times do |i|
    #forget 0
    i = i + 1
    value = i
    #start with one since i counts 
    
    count =1
    while value != 1
      
      if value.even?
        value = value / 2
      else
        value = value *3 +1
      end
      
      count+=1
      
    end
    
    if count > max_chain
      puts "New Max chain is #{count}, #{i}"
      max_chain = count
      chain_start = i
    end
  end
 
  return chain_start
end

limit = 1000000
longest_chain = find_longest_chain(limit)
#837799
puts "The longest chain for limit #{limit} is #{longest_chain}."