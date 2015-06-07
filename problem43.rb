class Problem43

  def find_solution
    nums = [0,1,2,3,4,5,6,7,8,9]
    # nums = [0,1]
    sum = 0

    @pandigital_nums = []
    create_pandigitals(nums, 0, 0)
    @pandigital_nums.each do |num| 

      sum += num if (substring_property?(num))
    end

    puts sum;


  end

  private
    def create_pandigitals(nums, index, current_number)


      # puts "#{nums}, #{index}, #{current_number}"
      if (index ==nums.count)
        @pandigital_nums << current_number
        return 
      end

      index.upto(nums.count - 1) do |i|

        # swap
        nums[i], nums[index] = nums[index], nums[i]
        num = nums[index] * 10 ** index

        current_number += num
        create_pandigitals(nums, index +1,  current_number)
        
        current_number -= num
        nums[i], nums[index] = nums[index], nums[i]
        # swap back

      end

    end

    def substring_property?(num)
      digits = []
      original_num = num;
      if num < 1000000000
        return 
      end

      while (num > 0)
        digit = num % 10
        digits << digit
        num = num / 10

      end
    
      digits.reverse!


      return false if ((digits[1] * 100 + digits[2] * 10 + digits[3]) % 2 != 0)
      return false if ((digits[2] * 100 + digits[3] * 10 + digits[4]) % 3 != 0)
      return false if ((digits[3] * 100 + digits[4] * 10 + digits[5]) % 5 != 0)
      return false if ((digits[4] * 100 + digits[5] * 10 + digits[6]) % 7 != 0)
      return false if ((digits[5] * 100 + digits[6] * 10 + digits[7]) % 11 != 0)
      return false if ((digits[6] * 100 + digits[7] * 10 + digits[8]) % 13 != 0)
      return false if ((digits[7] * 100 + digits[8] * 10 + digits[9]) % 17 != 0)


        return true
    end

end

# class Problem43

#   def initialize

#   end


#   def find_solution
#     sum = 0

#     1023456789.upto(9876543210) do |num|

#       if (pandigital?(num))
#         puts "pandigitial #{num}"
#         sum += num if (substring_property?(num))
#       end
#     end

#     return sum
#   end


#   private 

#     def pandigital?(num)
#       digits = []

#       while (num > 0)
#         digit = num % 10
        
#         return false if (digits[digit] == true)

#         digits[digit] = true

#         num = num / 10

#       end

#       return true

#     end

#     def substring_property?(num)

#       digits = []

#       while (num > 0)
#         digit = num % 10
#         digits << digit
#         num = num / 10

#       end

#       digits.reverse!

#       return false if (digit[1] * 100 + digit[2] *10 + digit[3]) % 2 != 0
#       return false if (digit[2] * 100 + digit[3] *10 + digit[4]) % 3 != 0
#       return false if (digit[3] * 100 + digit[4] *10 + digit[5]) % 5 != 0
#       return false if (digit[4] * 100 + digit[5] *10 + digit[6]) % 7 != 0
#       return false if (digit[5] * 100 + digit[6] *10 + digit[7]) % 11 != 0
#       return false if (digit[6] * 100 + digit[7] *10 + digit[8]) % 13 != 0
#       return false if (digit[7] * 100 + digit[8] *10 + digit[9]) % 17 != 0

#       return true

#     end

# end

# class Problem43

#   def find_solution
#     @multiples_of_17 = find_multiples(17)
#     @multiples_of_13 = find_multiples(13)
#     @multiples_of_11 = find_multiples(11)
#     @multiples_of_7 = find_multiples(7)
#     @multiples_of_5 = find_multiples(5)
#     @multiples_of_3 = find_multiples(3)
#     @multiples_of_2 = find_multiples(2)

#     return get_total()
    
#   end

#   private 

#     def get_total
#       num =0
      
#       @multiples_of_17.each do |value17|
#         num = value17
        
#         @multiples_of_13.each do |value13|
#           num += value13 * 1000
#           next if !unique?(num)

#           @multiples_of_11.each do |value11|
#             num += value11 * 1000000
#             next if !unique?(num)

#             @multiples_of_7.each do |value7|
#               num += value7 * 1000000000
#               next if !unique?(num)

#               @multiples_of_5.each do |value5|
#                 num += value5 * 1000000000000
#                 next if !unique?(num)

#                 @multiples_of_3.each do |value3|
#                   num += value3 * 1000000000000000
#                   next if !unique?(num)

#                   @multiples_of_2.each do |value2|
#                     num += value2 * 1000000000000000000



#                   end
#                 end
#               end
#             end
#           end
#         end
#       end

#     end

#     def get_pandigitial(num)
#       digits = []

#       while (num > 0)
#         digit = num % 10
        
#         return 0 if (digits[digit] == true)

#         digits[digit] = true

#         num = num / 10

#       end

#       newDigit = 0
#       if (digits[0] == nil)
#         return 0
#       end

#       1.upto(9) do |index| 


#       end

#       num += newDigit * 1000000000


#     end

#     def find_multiples(num)
#       index = 1
#       product = num * index

#       multiples = []

#       while product < 1000

#         multiples << product if product > 100 and unique?(product)

#         index += 1

#         product = num * index
#       end

#       return multiples

#     end

#     def unique?(num)
#       digits = []

#       while (num > 0)
#         digit = num % 10
        
#         return false if (digits[digit] == true)

#         digits[digit] = true

#         num = num / 10

#       end

#       return true

#     end



# end


problem43 = Problem43.new

puts problem43.find_solution