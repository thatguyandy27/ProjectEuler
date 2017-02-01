//
//  Problem60.h
//  ProjectEuler
//
//  Created by Andy Meyers on 1/31/17.
//  Copyright © 2017 Andrew Meyers. All rights reserved.
//

#ifndef Problem60_h
#define Problem60_h

#include <stdio.h>
#include "Prime.h"

class Problem60{
public:
    void generate_answer();
    
private:
    bool is_prime_pair(int, int);
    std::vector<int> primes;
    std::vector<bool> prime_hash;
};


#endif /* Problem60_h */
