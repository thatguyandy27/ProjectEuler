require 'prime'

class Problem49

  def solve_problem

    primes = get_four_digit_primes


    found = false
    index = 0

    while (!found and primes.count > index )
      found = check_for_permutations(primes[index], primes)
      index += 1
    end


  end

  private 

    def get_four_digit_primes

      four_digit_primes = []

      Prime.each (10000) do |p|
        four_digit_primes << p if p > 1000

      end 

      return four_digit_primes

    end

    def check_for_permutations(num, primes)
      permutations = []

      get_permutations(num.to_s, 0, permutations)

      permutation_primes = []

      permutations.each do |p|

        permutation_primes << p if primes.find_index(p) != nil

      end

      permutation_primes.sort!

      puts "#{num}, #{permutation_primes.count}"

      if (permutation_primes.count >= 3 )
        check_for_difference(permutation_primes)
        # are_equal =  permutation_primes[1] - permutation_primes[0] == permutation_primes[2] - permutation_primes[1]
#        puts "#{permutation_primes[0]}#{permutation_primes[1]}#{permutation_primes[2]}... #{are_equal} "

        return false

      end

      return false

    end

    def check_for_difference(nums)

      x_index =0

      found = false

      while (!found && x_index < nums.length)
        x_num = nums[x_index]
        difference = 0

        x_index +=1

        (x_index + 1).upto(nums.length - 1) do |y_index|
          y_num = nums[y_index]

          difference = y_num - x_num

          (y_index +1).upto(nums.length - 1) do |z_index|
            z_num = nums[z_index]
            diff2 = z_num - y_num

            if (diff2 == difference)

              puts "#{x_num} - #{y_num} - #{z_num}"
              found = true
            elsif diff2 > difference
              break

            end

          end

        end


      end




    end

    def get_permutations(s_num, index, permutations)

      if (index == s_num.length)
        permutations << s_num.to_i
        return 
      end

      index.upto(s_num.length - 1) do |swap_i|

        s_num[index], s_num[swap_i] = s_num[swap_i], s_num[index]
        get_permutations(s_num, index + 1, permutations)
        s_num[index], s_num[swap_i] = s_num[swap_i], s_num[index]

      end

    end

end


problem49 = Problem49.new

problem49.solve_problem