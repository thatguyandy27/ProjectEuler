//
//  Problem99.h
//  ProjectEuler
//
//  Created by Andrew Meyers on 10/9/16.
//  Copyright © 2016 Andrew Meyers. All rights reserved.
//

#ifndef Problem99_h
#define Problem99_h

#include <vector>

class Problem99{
public:
    void generate_answer();
    
private:
    void load_data();
    
    std::vector<std::vector<double>> values;
};

#endif /* Problem99_hpp */
