//
//  Problem62.h
//  ProjectEuler
//
//  Created by Andrew Meyers on 10/10/16.
//  Copyright © 2016 Andrew Meyers. All rights reserved.
//

#ifndef Problem62_h
#define Problem62_h

#include <map>

class Problem62Data{
public:
    long long min_value;
    int count;
};


class Problem62{
public:
    void generate_answer();
    
private:
    std::map<long long,Problem62Data> table;
};


#endif /* Problem62_hpp */
