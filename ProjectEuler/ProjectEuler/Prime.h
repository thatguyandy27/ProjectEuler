//
//  Prime.h
//  ProjectEuler
//
//  Created by Andy Meyers on 1/31/17.
//  Copyright © 2017 Andrew Meyers. All rights reserved.
//

#ifndef Prime_h
#define Prime_h

#include <stdio.h>
#include <vector>

class Prime{
public:
    static std::vector<int> GeneratePrimes(int);
    static std::vector<bool> GetSeive(int);
};

#endif /* Prime_h */
