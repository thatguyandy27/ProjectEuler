#1, 3, 5, 7, 9, 13, 17, 21, 25, 31, 37, 43, 49 

def generate_spiral(size)
  spiral = Array.new(2) {Array.new(size)}

  size.downto(1) do |i|
    puts "i: #{i}"
    if i.odd?
      xstart = i-1
      xend = size - 1 - xstart
      ystart = xend
      yend = xstart
      number = i * i 
      
      xstart.downto(xend) do |x|
        puts "3.  x:#{x}, y:#{ystart} #{xstart}, number #{number}"
        spiral[x][ystart] = number
        number -= 1
        
      end
      (ystart).upto(yend) do |y|
        puts "4.  x:#{xend}, y:#{y}, number #{number}"
        spiral[xend][y] = number
        number -= 1
      
      end
    else
      xstart = size - i
      xend = size - xstart - 1
      ystart = xend
      yend = xstart
      number = i * i 
      
      xstart.upto(xend) do |x|
        puts "1.  x:#{x}, y:#{ystart}, number #{number}"
        spiral[x][ystart] = number
        number -= 1
        
      end
      
      (ystart - 1).downto(yend) do |y|
        puts "2.  x:#{xend}, y:#{y}, number #{number}"
        spiral[xend][y] = number
        number -= 1
      
      end
    
    
    end
  end
  return spiral
  #end
end

def get_sum_of_spiral(spiral)
  max = spiral * spiral
  sum = 1
  num = 1
  multiplier = 2
  
  while num < max
    4.times() do |x|
      num += multiplier
      sum += num
    end
    
    multiplier +=2
    
  end
  
  return sum
  
end

sum = get_sum_of_spiral(1001)
puts "#{sum}"
#spiral = generate_spiral(3)
#puts "#{spiral}"