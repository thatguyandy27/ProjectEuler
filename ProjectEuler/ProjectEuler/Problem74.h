//
//  Problem74.h
//  ProjectEuler
//
//  Created by Andrew Meyers on 10/12/16.
//  Copyright © 2016 Andrew Meyers. All rights reserved.
//

#ifndef Problem74_h
#define Problem74_h

#include <vector>

class Problem74{
public:
    void generate_answer();
    
private:
    void update_factorial_sums();
    long get_sum_of_factorials(long);
    void set_chains_of_sixty();
    std::vector<int> is_chain_of_sixty; // 1, 0, -1
    std::vector<long> factorial_sums;
};

#endif /* Problem74_hpp */
