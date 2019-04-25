#include <iostream>
#include <map>
#include <vector>




template <typename T>
void test(T& arg){

}


int testConstMap(const std::map<int,int>& map)
{
    auto ite = map.find(1);
    return ite != map.end() ? ite->second : 0;
}



typedef int T;

typedef std::function<T*()> StepHandleFunc ;

typedef std::map<std::string,StepHandleFunc> StepHandleMap;

typedef std::string StepState;

typedef std::pair<StepState,StepHandleFunc> StepStateHandle;
using namespace std;

// [0,0,1,1,1,1,2,3,3],
// [1,1,1,2,2,3]


int main() {
    std::string str1 = "11";
    const auto &str2 = str1;

    if(str1 == "11" || str1 == "22"){
        cout<<str1;
    }

    /*std::vector<StepStateHandle> stepStateHandleVec;

    stepStateHandleVec.emplace_back("login",[](){
        cout<<2;
        return new T(0);
    });

    stepStateHandleVec.emplace_back("other_state",[](){
        cout<<0;
        return new T(1);
    });
    map<int,int> map1;
    map1[1] = 1;
    map<int,int> map2;
    auto & ref = map1.count(1) ? map1 : map2;

    cout<<ref[1];
    StepState state = "login";
    std::for_each(stepStateHandleVec.begin(),stepStateHandleVec.end(),[&](StepStateHandle& handle){
        if(handle.first == state)
            handle.second();
    });



    for(auto& item : stepStateHandleVec){
        if(state == item.first){
            item.second();
            break;
        }
    }


    StepHandleMap stepHandleMap;
    stepHandleMap["login"] = [](){
        return new T(0);
    };

    stepHandleMap["other_state"] = [](){
        return new T(1);
    };


    std::string your_arg = "login";

    stepHandleMap[your_arg]();

*/












    return 0;
}